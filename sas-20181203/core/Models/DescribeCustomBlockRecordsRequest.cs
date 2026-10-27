// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCustomBlockRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The IP address to be blocked to prevent brute-force attacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>117.66.XX.XX</para>
        /// </summary>
        [NameInMap("BlockIp")]
        [Validation(Required=false)]
        public string BlockIp { get; set; }

        /// <summary>
        /// <para>Specifies the page number of the returned results. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Settings for paging. Specifies the number of records to return on each page during a paged query. Default value: <b>20</b>, which indicates that 20 records are displayed on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The status of the defense rule against brute-force attacks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: invalid</description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>2</b>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
