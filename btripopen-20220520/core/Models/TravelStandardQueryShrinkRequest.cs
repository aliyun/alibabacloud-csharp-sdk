// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TravelStandardQueryShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use the group travel standard.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("from_group")]
        [Validation(Required=false)]
        public bool? FromGroup { get; set; }

        /// <summary>
        /// <para>The personnel rule code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2006523763</para>
        /// </summary>
        [NameInMap("rule_code")]
        [Validation(Required=false)]
        public long? RuleCode { get; set; }

        /// <summary>
        /// <para>The service categories to query.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("service_type_list")]
        [Validation(Required=false)]
        public string ServiceTypeListShrink { get; set; }

    }

}
