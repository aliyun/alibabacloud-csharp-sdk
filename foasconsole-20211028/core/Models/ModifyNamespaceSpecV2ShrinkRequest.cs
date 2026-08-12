// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class ModifyNamespaceSpecV2ShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The upper limit of pay-as-you-go resources allocated to the project namespace.</para>
        /// </summary>
        [NameInMap("ElasticResourceSpec")]
        [Validation(Required=false)]
        public string ElasticResourceSpecShrink { get; set; }

        /// <summary>
        /// <para>The size of subscription resources allocated to the project namespace.</para>
        /// </summary>
        [NameInMap("GuaranteedResourceSpec")]
        [Validation(Required=false)]
        public string GuaranteedResourceSpecShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the project namespace uses zone-disaster recovery.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The order instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f-cn-wwo36qj****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The project namespace name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>di-5934394438****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
