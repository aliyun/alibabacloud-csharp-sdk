// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeCheckDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return on each page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Set this parameter to the value of NextToken that is returned from the last API call. For more information about how to set this parameter, see the API description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae**********699</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ecs:123<em><b>890:cn-shanghai:instance/i-001</b></em>90</para>
        /// </summary>
        [NameInMap("ResourceArn")]
        [Validation(Required=false)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// <para>The unique ID of the data protection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-000***dav</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

    }

}
