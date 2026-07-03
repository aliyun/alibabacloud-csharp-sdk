// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListDpiGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The application group ID.</para>
        /// <para>You can query information about one or more application groups by specifying their IDs. You can query up to 10 application groups at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public List<string> DpiGroupIds { get; set; }

        /// <summary>
        /// <para>The application group name.</para>
        /// <para>You can query information about one or more application groups by specifying their names. You can query up to 10 application groups at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P2P</para>
        /// </summary>
        [NameInMap("DpiGroupNames")]
        [Validation(Required=false)]
        public List<string> DpiGroupNames { get; set; }

        /// <summary>
        /// <para>The number of application groups to return on each page.</para>
        /// <para>Valid values: <b>1</b> to <b>100</b>.</para>
        /// <para>Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFPSpX59Eb****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to query the regions and their IDs that Smart Access Gateway supports.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
