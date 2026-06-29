// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetStandardTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition.</para>
        /// </summary>
        [NameInMap("FilterQuery")]
        [Validation(Required=false)]
        public string FilterQueryShrink { get; set; }

        /// <summary>
        /// <para>The standard template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow a null value to be returned when the template does not exist. If set to false, an exception is thrown. Default value: true.</para>
        /// </summary>
        [NameInMap("Nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

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

    }

}
