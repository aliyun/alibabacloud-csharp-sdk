// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineBuildRequest : TeaModel {
        /// <summary>
        /// <para>The OSS object URL. This parameter is required in upload mode but is not required in git mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket.oss-.aliyuncs.com/key">https://bucket.oss-.aliyuncs.com/key</a></para>
        /// </summary>
        [NameInMap("ArtifactUrl")]
        [Validation(Required=false)]
        public string ArtifactUrl { get; set; }

        /// <summary>
        /// <para>The name of the branch to build. This parameter is not required in upload mode but is required in git mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <para>The ER name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rwa-test</para>
        /// </summary>
        [NameInMap("RoutineName")]
        [Validation(Required=false)]
        public string RoutineName { get; set; }

    }

}
