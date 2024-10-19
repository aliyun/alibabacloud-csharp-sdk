// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AttachApiProductRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API product.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>117b7a64a8b3f064eaa4a47ac62aac5e</para>
        /// </summary>
        [NameInMap("ApiProductId")]
        [Validation(Required=false)]
        public string ApiProductId { get; set; }

        /// <summary>
        /// <para>The APIs to be attached.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public List<AttachApiProductRequestApis> Apis { get; set; }
        public class AttachApiProductRequestApis : TeaModel {
            /// <summary>
            /// <para>The API ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>551877242a4b4f3a84a56b7c3570e4a7</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public string ApiId { get; set; }

            /// <summary>
            /// <para>The environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RELEASE</b>: the production environment</description></item>
            /// <item><description><b>PRE</b>: the staging environment</description></item>
            /// <item><description><b>TEST</b>: the test environment</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RELEASE</para>
            /// </summary>
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }

        }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
