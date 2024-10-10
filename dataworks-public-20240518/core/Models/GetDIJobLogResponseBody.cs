// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDIJobLogResponseBody : TeaModel {
        /// <summary>
        /// <para>代表资源一级ID的资源属性字段</para>
        /// 
        /// <b>Example:</b>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <remarks>
        /// <para>stdout:n++++++++++++++++++executing sql: create database if not exists jindo_test location \&quot;oss://pangbei-hdfs/tmp/hive\&quot; n++n</para>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </remarks>
        /// </summary>
        [NameInMap("Log")]
        [Validation(Required=false)]
        public string Log { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
