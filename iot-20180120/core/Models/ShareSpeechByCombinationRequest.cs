// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ShareSpeechByCombinationRequest : TeaModel {
        /// <summary>
        /// The audio format. Valid values: **wav**, **mp3**, and **amr**.
        /// </summary>
        [NameInMap("AudioFormat")]
        [Validation(Required=false)]
        public string AudioFormat { get; set; }

        /// <summary>
        /// The combined content that you want to broadcast. The following types of content can be broadcasted:
        /// 
        /// *   The speeches that are pushed to the device. You must specify the identifiers of the speeches.
        /// 
        /// *   The custom content that you specify based on the supported format of the device.
        /// 
        ///     For example, you can create a custom speech about the amount of money in the format of `{$xxx}`. xxx is the specific amount. If you specify `{$1000}`, the device broadcasts **CNY 1000**.
        /// 
        /// The device broadcasts the audio files in the sequence of the values that you specify in CombinationList.
        /// </summary>
        [NameInMap("CombinationList")]
        [Validation(Required=false)]
        public List<string> CombinationList { get; set; }

        /// <summary>
        /// The **DeviceName** of the device. If you specify this parameter, you must also specify the **ProductKey** parameter.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// The ID of the device. You can call the [QuerySpeechDevice](~~280408~~) operation to obtain the ID.
        /// 
        /// > If you specify this parameter, you do not need to specify the **ProductKey** and **DeviceName** parameters. **IotId** specifies a globally unique identifier (GUID) of the device, which corresponds to a combination of **ProductKey** and **DeviceName**. If you specify the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The instance ID. You can view the **ID** of the instance on the **Overview** page in the IoT Platform console.
        /// 
        /// >  If your instance has an ID, you must specify this parameter. Otherwise, the request fails. If no Overview page exists or no instance ID is displayed, you do not need to specify this parameter.
        /// 
        /// For more information, see the [Overview](~~356505~~) topic of IoT instances.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The **ProductKey** of the product to which the device belongs. If you specify this parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The unique ID of the combined speech that you want to broadcast. This ID is issued by IoT Platform to the device.
        /// 
        /// >  If you do not specify this parameter, IoT Platform automatically generates an ID. If you need to retry broadcasting the speech, you must specify the ID to prevent repeated broadcasting.
        /// </summary>
        [NameInMap("SpeechId")]
        [Validation(Required=false)]
        public string SpeechId { get; set; }

    }

}
