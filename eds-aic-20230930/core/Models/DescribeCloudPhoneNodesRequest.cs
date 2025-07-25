// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeCloudPhoneNodesRequest : TeaModel {
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The billing method. Only the subscription billing method is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If a query doesn\&quot;t return all results, the response includes a NextToken value for pagination. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uONHqPtDLM2U8s****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The matrix IDs.</para>
        /// </summary>
        [NameInMap("NodeIds")]
        [Validation(Required=false)]
        public List<string> NodeIds { get; set; }

        /// <summary>
        /// <para>The matrix name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_name</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The matrix specification.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cpm.gn6.gx1</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cpm.gn6.gx1</para>
        /// </summary>
        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        /// <summary>
        /// <para>The matrix status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FAILED: The matrix failed to be created.</description></item>
        /// <item><description>RUNNING: The matrix is available.</description></item>
        /// <item><description>DELETING: The matrix is being deleted.</description></item>
        /// <item><description>NODE_READY: The matrix is ready, and cloud phone instances are being created.</description></item>
        /// <item><description>DELETED: The matrix is deleted.</description></item>
        /// <item><description>CREATING: The matrix is being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CREATING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
