// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskExecDetailRequest : TeaModel {
        /// <summary>
        /// <para>The task batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BatchVersion")]
        [Validation(Required=false)]
        public int? BatchVersion { get; set; }

        /// <summary>
        /// <para>The ID of the campaign associated with the outbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CaseId")]
        [Validation(Required=false)]
        public long? CaseId { get; set; }

        /// <summary>
        /// <para>The execution status of a single number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Pending.</description></item>
        /// <item><description><b>2</b>: Calling.</description></item>
        /// <item><description><b>3</b>: Completed.</description></item>
        /// <item><description><b>4</b>: Terminated.</description></item>
        /// <item><description><b>5</b>: Pending recall.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CaseStatus")]
        [Validation(Required=false)]
        public int? CaseStatus { get; set; }

        /// <summary>
        /// <para>The end time for number import. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632290119000</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public long? CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time for number import. The value is a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632289999000</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public long? CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The AICCS instance ID. You can obtain the ID in the <b>Instance Management</b> section of the left-side navigation pane in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The outbound call number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150****000</para>
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/312260.html">CreateAiOutboundTask</a> operation and view the <b>Data</b> response parameter, or call the <a href="https://help.aliyun.com/document_detail/2718026.html">GetAiOutboundTaskList</a> operation and view the <b>TaskId</b> response parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
