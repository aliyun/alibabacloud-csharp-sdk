// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeMOTokenUsageDetailRequest : TeaModel {
        /// <summary>
        /// <para>The API key used for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-rds-*****</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The consumer associated with the API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16<b><b><b>4_rds_copilot</b></b>_public_cn-4</b>**02</para>
        /// </summary>
        [NameInMap("ConsumerName")]
        [Validation(Required=false)]
        public string ConsumerName { get; set; }

        /// <summary>
        /// <para>The cursor-based pagination token. This parameter takes priority over Page. Leave this parameter empty for the first call. For subsequent calls, use the NextCursor value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzNDUsInRzIjoiMjAyNi0wNC0wOFQwMDowMDowMFoifQ==</para>
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>The end time in ISO 8601 format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-13T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The model that was called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-flash</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The start time in ISO 8601 format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-04T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The type of usage to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("UsageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

    }

}
