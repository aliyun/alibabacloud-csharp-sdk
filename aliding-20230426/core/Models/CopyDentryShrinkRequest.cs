// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CopyDentryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9XJljElJv6RPGyA</para>
        /// </summary>
        [NameInMap("DentryId")]
        [Validation(Required=false)]
        public string DentryId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24458420428</para>
        /// </summary>
        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9XJljElJv6RPG</para>
        /// </summary>
        [NameInMap("TargetSpaceId")]
        [Validation(Required=false)]
        public string TargetSpaceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b9XJljElJv6RPGyA2</para>
        /// </summary>
        [NameInMap("ToNextDentryId")]
        [Validation(Required=false)]
        public string ToNextDentryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b9XJljElJv6RPGyA4</para>
        /// </summary>
        [NameInMap("ToParentDentryId")]
        [Validation(Required=false)]
        public string ToParentDentryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b9XJljElJv6RPGyA3</para>
        /// </summary>
        [NameInMap("ToPrevDentryId")]
        [Validation(Required=false)]
        public string ToPrevDentryId { get; set; }

    }

}
