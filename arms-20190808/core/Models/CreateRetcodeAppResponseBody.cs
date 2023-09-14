// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRetcodeAppResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful. If another status code is returned, the request failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The return detail.
        /// </summary>
        [NameInMap("RetcodeAppDataBean")]
        [Validation(Required=false)]
        public CreateRetcodeAppResponseBodyRetcodeAppDataBean RetcodeAppDataBean { get; set; }
        public class CreateRetcodeAppResponseBodyRetcodeAppDataBean : TeaModel {
            /// <summary>
            /// The application ID.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// PID.
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// 
            /// If this parameter is left empty, the default resource group is used. You can view the resource group ID on the Resource Group page in the Resource Management console.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public CreateRetcodeAppResponseBodyRetcodeAppDataBeanTags Tags { get; set; }
            public class CreateRetcodeAppResponseBodyRetcodeAppDataBeanTags : TeaModel {
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<CreateRetcodeAppResponseBodyRetcodeAppDataBeanTagsTags> Tags { get; set; }
                public class CreateRetcodeAppResponseBodyRetcodeAppDataBeanTagsTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
