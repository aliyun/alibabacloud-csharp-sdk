// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the task execution, in 13-digit timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683772744953</para>
        /// </summary>
        [NameInMap("EndMillis")]
        [Validation(Required=false)]
        public long? EndMillis { get; set; }

        /// <summary>
        /// <para>Set the language type for requests and received messages. The default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Set which page to start displaying the query results from. The default value is 1, indicating the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Specify the maximum number of data entries per page when performing a paginated query. The default number of entries per page is 20. If the PageSize parameter is empty, it will return 10 entries by default.</para>
        /// <remarks>
        /// <para>It is recommended not to leave the PageSize value empty.</para>
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
        /// <para>You can obtain this parameter by calling the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> interface.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8f55e76d-b5d5-4720-9cd7-xxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>UUID of the playbook task execution.</para>
        /// <remarks>
        /// <para>You can obtain this parameter by calling the <a href="https://help.aliyun.com/document_detail/2627455.html">DescribeSoarRecords</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6d412cfa-0905-4567-8a83-xxxxxx</para>
        /// </summary>
        [NameInMap("RequestUuid")]
        [Validation(Required=false)]
        public string RequestUuid { get; set; }

        /// <summary>
        /// <para>The start time of the task execution, in 13-digit timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526284584</para>
        /// </summary>
        [NameInMap("StartMillis")]
        [Validation(Required=false)]
        public long? StartMillis { get; set; }

        /// <summary>
        /// <para>The status of the task execution. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: Successful task.</description></item>
        /// <item><description><b>failed</b>: Failed task.</description></item>
        /// <item><description><b>inprogress</b>: Task in progress</description></item>
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
        /// <para>The Alibaba Cloud account ID that executed the playbook task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127xxxx4392</para>
        /// </summary>
        [NameInMap("TriggerUser")]
        [Validation(Required=false)]
        public string TriggerUser { get; set; }

    }

}
