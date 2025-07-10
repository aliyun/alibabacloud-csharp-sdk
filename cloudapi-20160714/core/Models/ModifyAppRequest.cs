// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyAppRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the app.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20112314518278</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <para>The value must be 4 to 26 characters in length and can contain letters, digits, and underscores (_). It must start with a letter.</para>
        /// <para>This parameter is required only when you want to modify the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jiedian_pord</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The description of the app. The description can contain a maximum of 180 characters in length.</para>
        /// <para>This parameter is required only when you want to modify the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modidyTest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>扩展信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>110461946884</para>
        /// </summary>
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
            /// <para>The value of the tag.</para>
            /// <para>N can be an integer from 1 to 20.``</para>
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
            /// <para>N can be an integer from 1 to 20.``</para>
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
