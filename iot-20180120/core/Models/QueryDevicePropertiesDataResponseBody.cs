// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDevicePropertiesDataResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The start time to query on the next page.
        /// 
        /// You can use the value of the **NextTime** parameter as the value of the **StartTime** parameter when you query the next page of results.
        /// </summary>
        [NameInMap("NextTime")]
        [Validation(Required=false)]
        public long? NextTime { get; set; }

        /// <summary>
        /// Indicates whether the next page exists.
        /// 
        /// *   **true**: The next page exists.
        /// *   **false**: The next page does not exist.
        /// 
        /// If the return value of the **NextValid** parameter is **true**, you can use the value of the **NextTime** parameter as the value of the **StartTime** parameter when you query the next page of results.
        /// </summary>
        [NameInMap("NextValid")]
        [Validation(Required=false)]
        public bool? NextValid { get; set; }

        /// <summary>
        /// The list of property records returned if the call is successful. For more information, see **PropertyDataInfo**.
        /// </summary>
        [NameInMap("PropertyDataInfos")]
        [Validation(Required=false)]
        public QueryDevicePropertiesDataResponseBodyPropertyDataInfos PropertyDataInfos { get; set; }
        public class QueryDevicePropertiesDataResponseBodyPropertyDataInfos : TeaModel {
            [NameInMap("PropertyDataInfo")]
            [Validation(Required=false)]
            public List<QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfo> PropertyDataInfo { get; set; }
            public class QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfo : TeaModel {
                /// <summary>
                /// The identifier of the property.
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// The list of property records.
                /// </summary>
                [NameInMap("List")]
                [Validation(Required=false)]
                public QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoList List { get; set; }
                public class QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoList : TeaModel {
                    [NameInMap("PropertyInfo")]
                    [Validation(Required=false)]
                    public List<QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoListPropertyInfo> PropertyInfo { get; set; }
                    public class QueryDevicePropertiesDataResponseBodyPropertyDataInfosPropertyDataInfoListPropertyInfo : TeaModel {
                        /// <summary>
                        /// The time when the property was submitted. The value is a timestamp in milliseconds, such as 1579249499000.
                        /// </summary>
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public long? Time { get; set; }

                        /// <summary>
                        /// The value of the property.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. 
        /// 
        /// - **true**: The call was successful.
        /// - **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
