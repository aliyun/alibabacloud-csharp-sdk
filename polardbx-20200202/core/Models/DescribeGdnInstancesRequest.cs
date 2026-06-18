// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeGdnInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The message filter type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn_id、
        /// polarx_id</para>
        /// </summary>
        [NameInMap("FilterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <para>The filter value for querying resources.</para>
        /// <para>This parameter is used together with FilterKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-<em><b>、
        /// pxc-</b></em></para>
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// <para>The GDN ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-***</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
