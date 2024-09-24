// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the check item.</para>
        /// </summary>
        [NameInMap("CheckWarnings")]
        [Validation(Required=false)]
        public List<DescribeCheckWarningsResponseBodyCheckWarnings> CheckWarnings { get; set; }
        public class DescribeCheckWarningsResponseBodyCheckWarnings : TeaModel {
            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2546</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The ID of the alert that is generated for the baseline check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>212251441</para>
            /// </summary>
            [NameInMap("CheckWarningId")]
            [Validation(Required=false)]
            public long? CheckWarningId { get; set; }

            /// <summary>
            /// <para>The ID of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8de456b00ff0a2009ee8ef7fc59fd0457fa44f20b8282af3e79c2a0e2492****</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The name of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/svn-host</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The error message in the check result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ScriptKilledOfCpuHigh</para>
            /// </summary>
            [NameInMap("ExecErrorMessage")]
            [Validation(Required=false)]
            public string ExecErrorMessage { get; set; }

            /// <summary>
            /// <para>Indicates whether fixing is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Fixing is not supported.</description></item>
            /// <item><description><b>1</b>: Fixing is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FixStatus")]
            [Validation(Required=false)]
            public int? FixStatus { get; set; }

            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>passwordExpire</para>
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest processing of the check item risk of the machine. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1694692471000</para>
            /// </summary>
            [NameInMap("LastHandleTime")]
            [Validation(Required=false)]
            public long? LastHandleTime { get; set; }

            /// <summary>
            /// <para>The risk level of the risk item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ignore</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: failed.</description></item>
            /// <item><description><b>2</b>: verifying.</description></item>
            /// <item><description><b>3</b>: passed.</description></item>
            /// <item><description><b>5</b>: expired.</description></item>
            /// <item><description><b>6</b>: ignored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc.check.type.identity_auth</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the server on which the baseline check is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d42f938c-d962-48a0-90f9-****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>The number of entries returned per page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DFCADBA-7065-42DA-AF17-6868B9C2A8CF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
