// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ModifyEnterpriseAcceleratePolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>whiltelist</para>
        /// </summary>
        [NameInMap("AccelerationType")]
        [Validation(Required=false)]
        public string AccelerationType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eap-ce153a7165c8feea</para>
        /// </summary>
        [NameInMap("EapId")]
        [Validation(Required=false)]
        public string EapId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OnTls")]
        [Validation(Required=false)]
        public int? OnTls { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>999</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ShowInClient")]
        [Validation(Required=false)]
        public int? ShowInClient { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12.34.56.XX</para>
        /// </summary>
        [NameInMap("UpstreamHost")]
        [Validation(Required=false)]
        public string UpstreamHost { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("UpstreamPort")]
        [Validation(Required=false)]
        public int? UpstreamPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ga</para>
        /// </summary>
        [NameInMap("UpstreamType")]
        [Validation(Required=false)]
        public string UpstreamType { get; set; }

        [NameInMap("UserAttributeGroup")]
        [Validation(Required=false)]
        public string UserAttributeGroup { get; set; }

    }

}
