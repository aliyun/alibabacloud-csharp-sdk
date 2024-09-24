// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebLockFileEventsRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the event on web tamper proofing is handled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>n</b>: The event on web tamper proofing is handled.</description></item>
        /// <item><description><b>y</b>: The event on web tamper proofing is not handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("Dealed")]
        [Validation(Required=false)]
        public string Dealed { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys_create</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The name of the asset.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the names of assets.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test-ecs</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660649981419</para>
        /// </summary>
        [NameInMap("TsBegin")]
        [Validation(Required=false)]
        public long? TsBegin { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660649981419</para>
        /// </summary>
        [NameInMap("TsEnd")]
        [Validation(Required=false)]
        public long? TsEnd { get; set; }

    }

}
