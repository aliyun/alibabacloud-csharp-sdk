// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>If success is true, a list of tables that meet the criteria and their details are returned. If success is false, this parameter is empty.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<Table> Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If success is false, an error code is returned.</para>
        /// </description></item>
        /// <item><description><para>If success is true, this parameter is empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If success is false, an error message is returned.</para>
        /// </description></item>
        /// <item><description><para>If success is true, this parameter is empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The business status code. This is always 200. Use the success parameter to determine whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECE641B2-AB0B-4174-9C3B-885881558637</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
