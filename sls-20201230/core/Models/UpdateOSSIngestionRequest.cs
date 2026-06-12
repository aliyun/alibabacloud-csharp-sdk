// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateOSSIngestionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the OSS import task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public OSSIngestionConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the OSS import task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS import</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the OSS import task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS import</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The schedule of the task. This parameter is optional. To run the task at a fixed time, such as 08:00 every Monday, use a cron expression.</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
