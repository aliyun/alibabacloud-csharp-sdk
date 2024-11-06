// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeKvUsageDataRequest : TeaModel {
        /// <summary>
        /// <para>The request method. If the parameter is empty, data about all methods is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>get</b></description></item>
        /// <item><description><b>put</b></description></item>
        /// <item><description><b>list</b></description></item>
        /// <item><description><b>delete</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>get</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-10T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The type of the request data. Set the value to <b>acc</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The namespace ID. If the parameter is empty, data about all namespaces is returned.</para>
        /// <para>You can specify a maximum number of 30 namespace IDs and separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>12423131231****</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The type of the response data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>detail</b>: detailed data</description></item>
        /// <item><description><b>total</b>: summary data</description></item>
        /// </list>
        /// <para>Default value: <b>detail</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>detail</para>
        /// </summary>
        [NameInMap("ResponseType")]
        [Validation(Required=false)]
        public string ResponseType { get; set; }

        /// <summary>
        /// <para>The key that is used to group data. Valid values: <b>type</b> and <b>namespace</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>type</b>: Data is grouped by time. The data in the last 5 minutes is returned.</description></item>
        /// <item><description><b>namespace</b>: Data is grouped by namespace and is not padded with zeros.</description></item>
        /// <item><description>Default value: <b>type</b>.</description></item>
        /// </list>
        /// <para>If <b>ResponseType</b> is set to <b>total</b>, data to return is not grouped by <b>namespace</b> but by <b>type</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>type</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <para>The minimum data granularity is 1 hour. If you do not specify this parameter, the data in the last seven days is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-10T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
