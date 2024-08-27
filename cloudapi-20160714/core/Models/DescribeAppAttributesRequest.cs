// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppAttributesRequest : TeaModel {
        /// <summary>
        /// The AppCode of the app.
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// The ID of the app.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// The app key that is used to make an API call.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// The name of the app.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// Specifies whether to enable tag verification.
        /// </summary>
        [NameInMap("EnableTagAuth")]
        [Validation(Required=false)]
        public bool? EnableTagAuth { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The order. Valid values: asc and desc. Default value: desc.
        /// 
        /// *   asc: The apps are displayed in ascending order of modification time.
        /// *   desc: The apps are displayed in descending order of modification time.
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// The tag of objects that match the rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeAppAttributesRequestTag> Tag { get; set; }
        public class DescribeAppAttributesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// 
            /// N can be an integer from 1 to 20.``
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The key of the tag.
            /// 
            /// N can be an integer from 1 to 20.``
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
