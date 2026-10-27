// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePostPaidBindRelRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic binding for newly added assets. Valid values:</para>
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
        /// <para>The edition to automatically bind to newly added assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Premium Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("AutoBindVersion")]
        [Validation(Required=false)]
        public int? AutoBindVersion { get; set; }

        /// <summary>
        /// <para>The action parameters for the binding operation.</para>
        /// </summary>
        [NameInMap("BindAction")]
        [Validation(Required=false)]
        public List<UpdatePostPaidBindRelRequestBindAction> BindAction { get; set; }
        public class UpdatePostPaidBindRelRequestBindAction : TeaModel {
            /// <summary>
            /// <para>Specifies whether to bind all servers. Default value: <b>false</b>. Valid values:</para>
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
            /// <para>The type of free quota used for the binding operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>freeEnterprise</para>
            /// </summary>
            [NameInMap("FreeType")]
            [Validation(Required=false)]
            public string FreeType { get; set; }

            /// <summary>
            /// <para>The UUIDs of the specified servers.</para>
            /// </summary>
            [NameInMap("UuidList")]
            [Validation(Required=false)]
            public List<string> UuidList { get; set; }

            /// <summary>
            /// <para>The Security Center protection edition to bind. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Premium Edition</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request. A value of true indicates that only a dry run is performed and no actual operation is executed. A value of false indicates that the request is normally executed. Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sas</b>: Security Center</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

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
