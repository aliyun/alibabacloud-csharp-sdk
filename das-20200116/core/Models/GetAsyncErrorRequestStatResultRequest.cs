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
        /// <para>The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time. The interval between the start time and the end time cannot exceed 24 hours.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1642566830000</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> This parameter must be specified for PolarDB for MySQL instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp179lg03445l****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The ID of the SQL template. Separate multiple SQL IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/410746.html">GetAsyncErrorRequestListByCode</a> operation to query the ID of the SQL query for which MySQL error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad78a4e7d3ce81590c9dc2d5f4bc****,0f92feacd92c048b06a16617a633****</para>
        /// </summary>
        [NameInMap("SqlIdList")]
        [Validation(Required=false)]
        public string SqlIdList { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The beginning of the time range to query must be within the storage duration of the database instance and can be up to 90 days earlier than the current time.</para>
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
