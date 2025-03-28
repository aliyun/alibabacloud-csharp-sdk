// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SkipPreCheckResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace %s in ErrMessage.</para>
        /// <remarks>
        /// <para>If JobId is invalid, JobId is returned for DynamicMessage, and the following message is returned for ErrMessage: The Value of Input Parameter %s is not valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>JobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status codes returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The precheck task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C498360-7892-433C-847A-BA71A850****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The precheck task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b4my3zg929a****</para>
        /// </summary>
        [NameInMap("ScheduleJobId")]
        [Validation(Required=false)]
        public string ScheduleJobId { get; set; }

        /// <summary>
        /// <para>The shortened name of the precheck item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_SAME_OBJ</para>
        /// </summary>
        [NameInMap("SkipItems")]
        [Validation(Required=false)]
        public string SkipItems { get; set; }

        /// <summary>
        /// <para>The precheck item name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHECK_SAME_OBJ_DETAIL</para>
        /// </summary>
        [NameInMap("SkipNames")]
        [Validation(Required=false)]
        public string SkipNames { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
