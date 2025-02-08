// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCheckProcessesRequest : TeaModel {
        /// <summary>
        /// <para>Extension point event encoding.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>commit-file</para>
        /// </summary>
        [NameInMap("EventCode")]
        [Validation(Required=false)]
        public string EventCode { get; set; }

        /// <summary>
        /// <para>The message ID in DataWorks OpenEvent. You can obtain the ID from a received message when an extension point event is triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03400b03-b721-4c34-8727-2****1</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123333232</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123465</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The check status of the extension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CHECKING</description></item>
        /// <item><description>PASSED</description></item>
        /// <item><description>BLOCKED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
