// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListComputeMetricsBySignatureRequest : TeaModel {
        /// <summary>
        /// <para>The end time for the query. This value is a UNIX timestamp representing milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718590596556</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20240730****ddlr</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The job owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN$7632***@aliyun.com</para>
        /// </summary>
        [NameInMap("jobOwner")]
        [Validation(Required=false)]
        public string JobOwner { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The project names.</para>
        /// </summary>
        [NameInMap("projectNames")]
        [Validation(Required=false)]
        public List<string> ProjectNames { get; set; }

        /// <summary>
        /// <para>The SQL job signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m4S/2HipBVngCX94MNIAqmM7Ov4=</para>
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <para>The start time for the query. This value is a UNIX timestamp representing milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715393576201</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The metering type.</para>
        /// <list type="bullet">
        /// <item><description><c>ComputationSql</c>: the metering data of SQL jobs that are performed on internal tables.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

    }

}
