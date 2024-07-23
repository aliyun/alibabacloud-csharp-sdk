// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestSampleByInstanceIdRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time. The interval between the start time and the end time must be equal to or greater than 1 hour.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660104621000</para>
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
        /// <para>The role of the PolarDB-X 2.0 node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx_cn</b>: compute node.</description></item>
        /// <item><description><b>polarx_en</b>: data node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The SQL statement ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>651b56fe9418d48edb8fdf0980ec****</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The start time must be within the storage duration of the SQL Explorer feature of the database instance, and can be up to 90 days earlier than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1660097421000</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
        /// <remarks>
        /// <para> This parameter is optional. The system can automatically obtain the account ID based on the value of InstanceId when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>196278346919****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
