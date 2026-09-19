// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class ListTemplateCacheRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cae5f900-8b1d-4c0e-9c2a-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters by cache status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>InProgress</description></item>
        /// <item><description>Success</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>Evicted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The team ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13b721e6-8cc8-5df2-af13-80316f7508af</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The unique identifier of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>us7dxqaezw5uu7aa2cm5</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
