// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCriteriaStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c4af4fdf38a98496a9b63c2be5dae****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the image.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~GetOpaClusterImageList~~">GetOpaClusterImageList</a> operation to query the names of images.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testImage</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The tag that is added to the container.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~GetOpaClusterLabelList~~">GetOpaClusterLabelList</a> operation to query the tags that are added to containers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testlabel</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The namespace of the cluster.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~GetOpaClusterNamespaceList~~">GetOpaClusterNamespaceList</a> operation to query the namespaces of clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
