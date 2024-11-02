// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683772744953</para>
        /// </summary>
        [NameInMap("EndMillis")]
        [Validation(Required=false)]
        public long? EndMillis { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The page number. Default value: 1. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. If you do not specify the PageSize parameter, 10 entries are returned by default.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The playbook UUID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to query the playbook UUID.</para>
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
        /// <para>The beginning of the time range to query. The value is a 13-byte timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1683526284584</para>
        /// </summary>
        [NameInMap("StartMillis")]
        [Validation(Required=false)]
        public long? StartMillis { get; set; }

        /// <summary>
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>failed</b></description></item>
        /// <item><description><b>inprogress</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inprogress</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The MD5 value of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>be0a4ef084dd174abe478df52xxxxx</para>
        /// </summary>
        [NameInMap("TaskflowMd5")]
        [Validation(Required=false)]
        public string TaskflowMd5 { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to execute the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127xxxx4392</para>
        /// </summary>
        [NameInMap("TriggerUser")]
        [Validation(Required=false)]
        public string TriggerUser { get; set; }

    }

}
