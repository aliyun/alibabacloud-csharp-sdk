// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetTrackListRequest : TeaModel {
        /// <summary>
        /// <para>Sender address.</para>
        /// <remarks>
        /// <para>If not filled, it represents all addresses; if TagName is provided, this parameter must not be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.com">test@example.com</a></para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("DedicatedIp")]
        [Validation(Required=false)]
        public string DedicatedIp { get; set; }

        [NameInMap("DedicatedIpPoolId")]
        [Validation(Required=false)]
        public string DedicatedIpPoolId { get; set; }

        /// <summary>
        /// <para>End time, the span between start and end time cannot exceed 7 days. Format: yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Esp")]
        [Validation(Required=false)]
        public string Esp { get; set; }

        /// <summary>
        /// <para>For the first query, set to 0; for subsequent queries, fixed at 1. 1 indicates pagination in ascending order by time. (This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>(This field is deprecated)</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public string Offset { get; set; }

        /// <summary>
        /// <para>Used for pagination. Not set for the first query, but for subsequent queries, it should be set to the value of OffsetCreateTime from the previous response. (This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>(This field is deprecated)</para>
        /// </summary>
        [NameInMap("OffsetCreateTime")]
        [Validation(Required=false)]
        public string OffsetCreateTime { get; set; }

        /// <summary>
        /// <para>(This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>(This field is deprecated)</para>
        /// </summary>
        [NameInMap("OffsetCreateTimeDesc")]
        [Validation(Required=false)]
        public string OffsetCreateTimeDesc { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Start time, which cannot be earlier than 30 days. Format: yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-09-29</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Tag name</para>
        /// 
        /// <b>Example:</b>
        /// <para>tagname</para>
        /// </summary>
        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        /// <summary>
        /// <para>(This field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>(This field is deprecated)</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
