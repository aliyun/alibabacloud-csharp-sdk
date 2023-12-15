// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateAppRequest : TeaModel {
        /// <summary>
        /// The AppCode of the application.
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// The key of the application that is used to make an API call.
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// The name of the application. The name must be 4 to 26 characters in length. The name can contain letters, digits, and underscores (\_), and must start with a letter.
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// The password of the application.
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// The description of the application. The description can be up to 180 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The extended information.
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The tag of objects that match the rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAppRequestTag> Tag { get; set; }
        public class CreateAppRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// 
            /// Valid values of n: `[1, 20]`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag.
            /// 
            /// Valid values of n: `[1, 20]`. If the parameter has a value, you must specify a value for the tag key with the same N as tag.N.Key. Otherwise, an error is reported.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
