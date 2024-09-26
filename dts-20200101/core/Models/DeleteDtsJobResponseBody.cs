// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DeleteDtsJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>DeleteDtsJob</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>DeleteDtsJob</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b>: Data is synchronized from the source database to the destination database.</description></item>
        /// <item><description><b>Reverse</b>: Data is synchronized from the destination database to the source database.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>Forward</b>.</description></item>
        /// <item><description>You can set this parameter to <b>Reverse</b> to delete the reverse synchronization task only if the topology is two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>01B6F25-21E7-4484-99D5-3EF2625C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the data migration or synchronization task resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
