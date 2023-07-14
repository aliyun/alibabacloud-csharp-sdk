// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PrintByTemplateRequest : TeaModel {
        /// <summary>
        /// The DeviceName of the device.
        /// </summary>
        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("HistoryPrintTopic")]
        [Validation(Required=false)]
        public bool? HistoryPrintTopic { get; set; }

        /// <summary>
        /// The device ID.
        /// 
        /// > If you specify this parameter, you do not need to specify the **ProductKey** and **DeviceName** parameters. **IotId** specifies a globally unique identifier (GUID) of the device, which corresponds to a combination of **ProductKey** and **DeviceName**. If you specify the **IotId**, **ProductKey**, and **DeviceName** parameters, the value of the **IotId** parameter takes precedence.
        /// </summary>
        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// You do not need to specify this parameter.
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        /// <summary>
        /// The template parameters. You can obtain the template of receipts in the Letter Sending Service console, and configure parameters in the template to create a custom receipt that you want to print.
        /// </summary>
        [NameInMap("ParamsJsonString")]
        [Validation(Required=false)]
        public string ParamsJsonString { get; set; }

        /// <summary>
        /// The unique identifier of the product to which the device belongs.
        /// 
        /// > If you specify the **ProductKey** parameter, you must also specify the **DeviceName** parameter.
        /// </summary>
        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        /// <summary>
        /// The template identifier. You can obtain the template identifier in the Letter Sending Service console.
        /// </summary>
        [NameInMap("TemplateBizCode")]
        [Validation(Required=false)]
        public string TemplateBizCode { get; set; }

    }

}
