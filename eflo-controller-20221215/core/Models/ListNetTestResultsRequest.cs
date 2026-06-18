// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ListNetTestResultsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100.</para>
        /// <para>Default value:</para>
        /// <list type="bullet">
        /// <item><description>If you do not set this parameter or you set it to a value less than 20, the default value is 20.</description></item>
        /// <item><description>If you set the value to greater than 100, the default value is 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The type of the network test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DelayTest</para>
        /// </summary>
        [NameInMap("NetTestType")]
        [Validation(Required=false)]
        public string NetTestType { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Set this parameter to the value of \<c>NextToken\\</c> that is returned in the last response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a6b93229825ac667104463b5679****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxno4vh5****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
