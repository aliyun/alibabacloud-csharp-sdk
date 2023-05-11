// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceDesiredPropertyResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned in the **List** parameter if the call is successful.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceDesiredPropertyResponseBodyData Data { get; set; }
        public class QueryDeviceDesiredPropertyResponseBodyData : TeaModel {
            /// <summary>
            /// The desired property information returned in the **DesiredPropertyInfo** parameter.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public QueryDeviceDesiredPropertyResponseBodyDataList List { get; set; }
            public class QueryDeviceDesiredPropertyResponseBodyDataList : TeaModel {
                [NameInMap("DesiredPropertyInfo")]
                [Validation(Required=false)]
                public List<QueryDeviceDesiredPropertyResponseBodyDataListDesiredPropertyInfo> DesiredPropertyInfo { get; set; }
                public class QueryDeviceDesiredPropertyResponseBodyDataListDesiredPropertyInfo : TeaModel {
                    /// <summary>
                    /// The data type of the property.
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
                    /// The identifier of the property.
                    /// </summary>
                    [NameInMap("Identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// The name of the property.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The time when the desired value of the property was last modified. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("Time")]
                    [Validation(Required=false)]
                    public string Time { get; set; }

                    /// <summary>
                    /// The unit of the property.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The desired value of the property.
                    /// 
                    /// >  If you call the [ClearDeviceDesiredProperty](~~477431~~) operation to delete the desired value of the property, the **Value** parameter is not returned.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// The version of the desired value.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public long? Version { get; set; }

                }

            }

        }

        /// <summary>
        /// The error message that is returned if the call fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
