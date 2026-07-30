// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetAsyncErrorRequestStatResultRequest : TeaModel {
        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb01</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The end time of the query, specified as a Unix timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time. The interval between the start time and the end time cannot exceed 1 day.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1642566830000</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// <remarks>
        /// <para>This parameter is required for PolarDB for MySQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp179lg03445l****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>One or more SQL IDs. Separate multiple SQL IDs with commas. You can call the <a href="https://help.aliyun.com/document_detail/410746.html">GetAsyncErrorRequestListByCode</a> operation to query the SQL IDs that generated MySQL error codes on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad78a4e7d3ce81590c9dc2d5f4bc****,0f92feacd92c048b06a16617a633****</para>
        /// </summary>
        [NameInMap("SqlIdList")]
        [Validation(Required=false)]
        public string SqlIdList { get; set; }

        /// <summary>
        /// <para>The start time of the query, specified as a Unix timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>The start time must be within the data retention period of SQL Explorer for the database instance. The start time cannot be earlier than 90 days before the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1642556990714</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

    }

}
