// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The query command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("StandardGetQuery")]
        [Validation(Required=false)]
        public GetStandardRequestStandardGetQuery StandardGetQuery { get; set; }
        public class GetStandardRequestStandardGetQuery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to return associated standards and associated lookup tables. Default value: false.</para>
            /// </summary>
            [NameInMap("NeedRelation")]
            [Validation(Required=false)]
            public bool? NeedRelation { get; set; }

            /// <summary>
            /// <para>Specifies whether to return a null value when the standard does not exist. If set to false, an exception is thrown. Default value: true.</para>
            /// </summary>
            [NameInMap("Nullable")]
            [Validation(Required=false)]
            public bool? Nullable { get; set; }

            /// <summary>
            /// <para>The standard ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("StandardId")]
            [Validation(Required=false)]
            public long? StandardId { get; set; }

            /// <summary>
            /// <para>The stage to which the standard belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dev: development stage.</description></item>
            /// <item><description>prod: production stage.</description></item>
            /// </list>
            /// <para>Default value: prod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("StandardStage")]
            [Validation(Required=false)]
            public string StandardStage { get; set; }

            /// <summary>
            /// <para>The version number. If left empty, the latest version is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
