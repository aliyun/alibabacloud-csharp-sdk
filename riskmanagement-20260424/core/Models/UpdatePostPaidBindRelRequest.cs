// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class UpdatePostPaidBindRelRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Security Center SDK request parameters.</para>
        /// </summary>
        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public UpdatePostPaidBindRelRequestSdkRequest SdkRequest { get; set; }
        public class UpdatePostPaidBindRelRequestSdkRequest : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically bind newly added assets. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            /// <summary>
            /// <para>The edition to automatically bind when new assets are added. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Advanced Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AutoBindVersion")]
            [Validation(Required=false)]
            public int? AutoBindVersion { get; set; }

            /// <summary>
            /// <para>The list of binding action parameters.</para>
            /// </summary>
            [NameInMap("BindAction")]
            [Validation(Required=false)]
            public List<UpdatePostPaidBindRelRequestSdkRequestBindAction> BindAction { get; set; }
            public class UpdatePostPaidBindRelRequestSdkRequestBindAction : TeaModel {
                /// <summary>
                /// <para>Specifies whether to bind all assets. Default value: <b>false</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BindAll")]
                [Validation(Required=false)]
                public bool? BindAll { get; set; }

                /// <summary>
                /// <para>The list of specified server UUIDs.</para>
                /// <remarks>
                /// <para>Number of items &lt;= 1000. Number of items &gt;= 0.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("UuidList")]
                [Validation(Required=false)]
                public List<string> UuidList { get; set; }

                /// <summary>
                /// <para>The Security Center protection edition to bind. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition.</description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>5</b>: Advanced Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.</description></item>
                /// <item><description><b>7</b>: Ultimate Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to forcibly upgrade the edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UpdateIfNecessary")]
            [Validation(Required=false)]
            public bool? UpdateIfNecessary { get; set; }

        }

    }

}
