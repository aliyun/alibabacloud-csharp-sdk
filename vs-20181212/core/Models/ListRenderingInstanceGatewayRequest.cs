// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingInstanceGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The time range for filtering. The time must be in ISO 8601 format and in UTC, such as \<c>yyyy-MM-ddTHH:mm:ssZ\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-20T12:23:02Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-xxx</para>
        /// </summary>
        [NameInMap("GatewayInstanceId")]
        [Validation(Required=false)]
        public string GatewayInstanceId { get; set; }

        /// <summary>
        /// <para>The page number of the list to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the cloud application service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
        /// </summary>
        [NameInMap("RenderingInstanceId")]
        [Validation(Required=false)]
        public string RenderingInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter specifies the time range filter. The time must be in ISO 8601 format and UTC time, such as yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-05-18T02:20:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
