// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyAppRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20112314518278</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>The ID must be 4 to 26 characters in length and can contain letters, digits, and underscores (_). It must start with a letter.</para>
        /// <para>If you do not want to modify the existing value, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jiedian_pord</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The description of the application. The description can be up to 180 characters in length.</para>
        /// <para>If you do not want to modify the existing value, do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modidyTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The tag of objects that match the rule. You can specify multiple tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Key， Value</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ModifyAppRequestTag> Tag { get; set; }
        public class ModifyAppRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <para>Valid values of n: <c>[1, 20]</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// <para>Valid values of n: <c>[1, 20]</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
