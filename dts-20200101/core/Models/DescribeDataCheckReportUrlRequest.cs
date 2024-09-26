// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDataCheckReportUrlRequest : TeaModel {
        /// <summary>
        /// <para>The data verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: full data verification.</description></item>
        /// <item><description><b>2</b>: incremental data verification.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public int? CheckType { get; set; }

        /// <summary>
        /// <para>The name of the verified source database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsdb</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The ID of the Data Transmission Service (DTS) task. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f4612nr2182****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the table verified in the source database.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>student</para>
        /// </summary>
        [NameInMap("TbName")]
        [Validation(Required=false)]
        public string TbName { get; set; }

    }

}
