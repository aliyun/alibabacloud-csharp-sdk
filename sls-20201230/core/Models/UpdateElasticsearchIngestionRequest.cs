// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateElasticsearchIngestionRequest : TeaModel {
        /// <summary>
        /// <para>ES or OpenSearch ingestion configuration</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public ESIngestionConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>Description of the ES or OpenSearch ingestion task</para>
        /// 
        /// <b>Example:</b>
        /// <para>es ingestion test</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Display name of the ES or OpenSearch ingestion task</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-ingestion-test</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Scheduling type. Leave this field empty unless you need strict scheduling. For example, to run the ingestion task every Monday at 8:00 a.m., use a cron expression</para>
        /// </summary>
        [NameInMap("schedule")]
        [Validation(Required=false)]
        public Schedule Schedule { get; set; }

    }

}
