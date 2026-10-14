// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAICImagesRequest : TeaModel {
        /// <summary>
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Console test operation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the Android in Container (AIC) image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-ad0ddaddc2d54adeaa09b7c0f1e****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>public</b>: public image.</para>
        /// </description></item>
        /// <item><description><para><b>private</b>: custom image.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The URL of the AIC image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****.alibaba-inc.com/aic/socimage:test</para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The end time of the query. Format: &quot;2006-01-02&quot;. By default, no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: &quot;2006-01-02&quot;. By default, no time limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>The page number. The value starts from <b>1</b>.
        /// Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Maximum value: <b>100</b>.
        /// Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The image status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>verifying</b>: pending verification.</para>
        /// </description></item>
        /// <item><description><para><b>disable</b>: unavailable.</para>
        /// </description></item>
        /// <item><description><para><b>available</b>: available.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
