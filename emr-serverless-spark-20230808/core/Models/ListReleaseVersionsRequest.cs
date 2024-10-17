// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListReleaseVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the version.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>stable</description></item>
        /// <item><description>Beta</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>stable</para>
        /// </summary>
        [NameInMap("releaseType")]
        [Validation(Required=false)]
        public string ReleaseType { get; set; }

        /// <summary>
        /// <para>The version of EMR Serverless Spark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-2.1 (Spark 3.3.1, Scala 2.12, Java Runtime)</para>
        /// </summary>
        [NameInMap("releaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The status of the version.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ONLINE</description></item>
        /// <item><description>OFFLINE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ONLINE</para>
        /// </summary>
        [NameInMap("releaseVersionStatus")]
        [Validation(Required=false)]
        public string ReleaseVersionStatus { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-d2d82aa09155****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
