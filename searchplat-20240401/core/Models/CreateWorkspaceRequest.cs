// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>Billing type</para>
        /// <list type="bullet">
        /// <item><description>POSTPAY: Pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Engine type</para>
        /// <list type="bullet">
        /// <item><description>rag</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rag</para>
        /// </summary>
        [NameInMap("engineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>Workspace name</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Quota</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public CreateWorkspaceRequestQuota Quota { get; set; }
        public class CreateWorkspaceRequestQuota : TeaModel {
            /// <summary>
            /// <para>Compute resource (unit: LCU)</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("computeResource")]
            [Validation(Required=false)]
            public int? ComputeResource { get; set; }

            /// <summary>
            /// <para>Storage capacity (unit: GB)</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("docSize")]
            [Validation(Required=false)]
            public int? DocSize { get; set; }

            /// <summary>
            /// <para>Specification</para>
            /// <list type="bullet">
            /// <item><description>rag.share.common</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>rag.share.common</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        /// <summary>
        /// <para>Type</para>
        /// <list type="bullet">
        /// <item><description>standard</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
