// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CommitRoutineStagingCodeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the code version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description of this code ver</para>
        /// </summary>
        [NameInMap("CodeDescription")]
        [Validation(Required=false)]
        public string CodeDescription { get; set; }

        /// <summary>
        /// <para>The deployment environment whose environment variable configuration is used. If you do not specify this parameter, environment variables are not used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("DeployEnv")]
        [Validation(Required=false)]
        public string DeployEnv { get; set; }

        /// <summary>
        /// <para>The name of the Edge Routine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-routine1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
