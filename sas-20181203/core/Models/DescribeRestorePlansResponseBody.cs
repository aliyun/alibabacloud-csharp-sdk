// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestorePlansResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeRestorePlansResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeRestorePlansResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BE120DAB-F4E7-4C53-ADC3-A97578AB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array that consists of the restoration tasks.</para>
        /// </summary>
        [NameInMap("RestorePlans")]
        [Validation(Required=false)]
        public List<DescribeRestorePlansResponseBodyRestorePlans> RestorePlans { get; set; }
        public class DescribeRestorePlansResponseBodyRestorePlans : TeaModel {
            /// <summary>
            /// <para>The timestamp when the restoration task was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655174753****</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bankup****</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The name of the server on which the database resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql-test-001</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KtDataBase</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The point in time to which data is restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165875100****</para>
            /// </summary>
            [NameInMap("RestorePoint")]
            [Validation(Required=false)]
            public long? RestorePoint { get; set; }

            /// <summary>
            /// <para>The status of the restoration task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init</b>: initializing</description></item>
            /// <item><description><b>created</b>: creating</description></item>
            /// <item><description><b>running</b>: running</description></item>
            /// <item><description><b>completed</b>: complete</description></item>
            /// <item><description><b>error</b>: failed</description></item>
            /// <item><description><b>restoring</b>: restoring</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the destination database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OABak</para>
            /// </summary>
            [NameInMap("TargetDatabaseName")]
            [Validation(Required=false)]
            public string TargetDatabaseName { get; set; }

            /// <summary>
            /// <para>The ID of the destination server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-2zehqflgbl9ep2he****</para>
            /// </summary>
            [NameInMap("TargetInstanceId")]
            [Validation(Required=false)]
            public string TargetInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the destination server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hbr-detection-hh</para>
            /// </summary>
            [NameInMap("TargetInstanceName")]
            [Validation(Required=false)]
            public string TargetInstanceName { get; set; }

            /// <summary>
            /// <para>The timestamp when the restoration task was last updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>166849080****</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

    }

}
