// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdatePublishBatchRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the release batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52370</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>The name of the release batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("BatchName")]
        [Validation(Required=false)]
        public string BatchName { get; set; }

        /// <summary>
        /// <para>The interval between two release batches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The asset selection dimension. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: instance</description></item>
        /// <item><description><b>1</b>: machine group</description></item>
        /// <item><description><b>2</b>: VPC-based instance ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationBase")]
        [Validation(Required=false)]
        public int? OperationBase { get; set; }

    }

}
