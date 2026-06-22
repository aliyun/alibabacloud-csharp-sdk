// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyInterceptionTargetRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeContainerTags~~">DescribeContainerTags</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>yasintt-daemonst</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The list of images.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeContainerTags~~">DescribeContainerTags</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeContainerTags~~">DescribeContainerTags</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo4</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The list of labels.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeContainerTags~~">DescribeContainerTags</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// <para>The ID of the network object.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListInterceptionTargetPage~~">ListInterceptionTargetPage</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400913</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public long? TargetId { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test001</para>
        /// </summary>
        [NameInMap("TargetName")]
        [Validation(Required=false)]
        public string TargetName { get; set; }

        /// <summary>
        /// <para>The target type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE</b>: image.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
