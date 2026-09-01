// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The start time when the task was completed. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1755676363777</para>
        /// </summary>
        [NameInMap("CompletedBeginTime")]
        [Validation(Required=false)]
        public long? CompletedBeginTime { get; set; }

        /// <summary>
        /// <para>The end time when the task was completed. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526284584</para>
        /// </summary>
        [NameInMap("CompletedEndTime")]
        [Validation(Required=false)]
        public long? CompletedEndTime { get; set; }

        /// <summary>
        /// <para>The end time of the task run. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683772744953</para>
        /// </summary>
        [NameInMap("EndMillis")]
        [Validation(Required=false)]
        public long? EndMillis { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 10 entries are returned on each page.</para>
        /// <remarks>
        /// <para>Specify a value for PageSize.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>For more information, see <a href="~~DescribePlaybooks~~">DescribePlaybooks</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8f55e76d-b5d5-4720-9cd7-xxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The input parameter of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>input</para>
        /// </summary>
        [NameInMap("QueryValue")]
        [Validation(Required=false)]
        public string QueryValue { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook task execution.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/2627455.html">DescribeSoarRecords</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6d412cfa-0905-4567-8a83-xxxxxx</para>
        /// </summary>
        [NameInMap("RequestUuid")]
        [Validation(Required=false)]
        public string RequestUuid { get; set; }

        /// <summary>
        /// <para>The start time of the task run. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526284584</para>
        /// </summary>
        [NameInMap("StartMillis")]
        [Validation(Required=false)]
        public long? StartMillis { get; set; }

        /// <summary>
        /// <para>The status of the task run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>success</b>: The task is successful.</para>
        /// </description></item>
        /// <item><description><para><b>failed</b>: The task failed.</para>
        /// </description></item>
        /// <item><description><para><b>inprogress</b>: The task is in progress.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inprogress</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The MD5 value of the playbook configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>be0a4ef084dd174abe478df52xxxxx</para>
        /// </summary>
        [NameInMap("TaskflowMd5")]
        [Validation(Required=false)]
        public string TaskflowMd5 { get; set; }

        /// <summary>
        /// <para>The trigger type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>stream</b>: stream</para>
        /// </description></item>
        /// <item><description><para><b>debug</b>: test</para>
        /// </description></item>
        /// <item><description><para><b>manual</b>: manual</para>
        /// </description></item>
        /// <item><description><para><b>timer</b>: scheduled</para>
        /// </description></item>
        /// <item><description><para><b>SubInvoke</b>: child flow</para>
        /// </description></item>
        /// <item><description><para><b>siem</b>: triggered by a SIEM product</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>debug</para>
        /// </summary>
        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that runs the playbook task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127xxxx4392</para>
        /// </summary>
        [NameInMap("TriggerUser")]
        [Validation(Required=false)]
        public string TriggerUser { get; set; }

    }

}
