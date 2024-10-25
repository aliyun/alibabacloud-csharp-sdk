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
        /// <para>Test operation of console</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image ID of the AIC instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-ad0ddaddc2d54adeaa09b7c0f1e****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The type of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: public image</description></item>
        /// <item><description><b>private</b>: custom image</description></item>
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
        /// <para>The end of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02</para>
        /// </summary>
        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the 2006-01-02 format. By default, the time range to query is not restricted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02</para>
        /// </summary>
        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page <b>1</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is <b>100</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The status of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>verifying</b></description></item>
        /// <item><description><b>disable</b></description></item>
        /// <item><description><b>available</b></description></item>
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
