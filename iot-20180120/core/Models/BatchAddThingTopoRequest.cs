// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddThingTopoRequest : TeaModel {
        /// <summary>
        /// The name of the gateway.
        /// </summary>
        [NameInMap("GwDeviceName")]
        [Validation(Required=false)]
        public string GwDeviceName { get; set; }

        /// <summary>
        /// The key of the product to which the gateway belongs.
        /// </summary>
        [NameInMap("GwProductKey")]
        [Validation(Required=false)]
        public string GwProductKey { get; set; }

        /// <summary>
        /// The ID of the instance. On the **Overview** page in the IoT Platform console, you can view the ID of the instance.
        /// 
        /// >*   If your instance has an ID, you must specify this parameter. Otherwise, the call fails.
        /// >*   If no **Overview** page or instance ID appears in the IoT Platform console, ignore this parameter.
        /// 
        /// For more information, see [Overview](~~356505~~).
        /// </summary>
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("TopoAddItem")]
        [Validation(Required=false)]
        public List<BatchAddThingTopoRequestTopoAddItem> TopoAddItem { get; set; }
        public class BatchAddThingTopoRequestTopoAddItem : TeaModel {
            /// <summary>
            /// The client ID of the sub-device. The ID can be the serial number (SN) or media access control (MAC) address of the device. This parameter is optional.
            /// 
            /// > If this parameter is included in the value of the **TopoAddItem.N.Sign** parameter, you must specify this parameter.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The name of each sub-device.
            /// </summary>
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            /// <summary>
            /// The key of the product to which the sub-device belongs.
            /// </summary>
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            /// <summary>
            /// The signature of the sub-device.
            /// 
            /// Set the Sign parameter to the result of the **SignMethod(deviceSecret,content)** function.
            /// 
            /// To obtain the **content** parameter, sort all sub-device parameters that are submitted to the server, except the Sign and SignMethod parameters, in alphabetical order. Then, concatenate the parameters and values in sequence. No concatenation symbol is required to separate these parameters and values.
            /// 
            /// For example, you want to specify the following parameters for a sub-device: **ClientId=868575026974305, DeviceName=868575026974305, ProductKey=a1PB5fp1234, SignMethod=hmacmd5, timestamp=1646277090411, and deviceSecret=1234**. In this case, the signature function is `hmacmd5(1234, clientId868575026974305deviceName868575026974305productKeya1PB5fp1234timestamp1646277090411)`, and the calculation result is `3BA0DFA4C477B40C007D84D30D6466CC`.
            /// 
            /// >  In the preceding example, **ClientId** indicates the client ID of the sub-device. You can specify a custom client ID.
            /// 
            /// For more information about how to calculate the signature value, see [How do I obtain MQTT parameters for authentication?](~~292635~~). The signature value is the calculated value of the passwd parameter.
            /// </summary>
            [NameInMap("Sign")]
            [Validation(Required=false)]
            public string Sign { get; set; }

            /// <summary>
            /// The signature algorithm. Valid values: **hmacSha1**, **hmacSha256**, **hmacMd5**, and **Sha256**. The value is not case-sensitive.
            /// </summary>
            [NameInMap("SignMethod")]
            [Validation(Required=false)]
            public string SignMethod { get; set; }

            /// <summary>
            /// The timestamp in UTC. This parameter is optional.
            /// 
            /// > If this parameter is included in the value of the **TopoAddItem.N.Sign** parameter, you must specify this parameter.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

    }

}
