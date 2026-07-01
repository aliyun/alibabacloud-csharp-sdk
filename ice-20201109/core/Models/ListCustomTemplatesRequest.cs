// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListCustomTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-template</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The sort order of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CreationTime:Desc</c>: Sorts the results by Creation Time in descending order.</para>
        /// </description></item>
        /// <item><description><para><c>CreationTime:Asc</c>: Sorts the results by Creation Time in ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTimeDesc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The subtype of the template. This parameter applies only when <c>Type</c> is set to 1, 2, 7, or 9.</para>
        /// <list type="bullet">
        /// <item><description><para>Transcoding Template subtypes:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Normal (<c>Normal</c>)</para>
        /// </description></item>
        /// <item><description><para>2: Audio-only (<c>AudioTranscode</c>)</para>
        /// </description></item>
        /// <item><description><para>3: Remuxing (<c>Remux</c>)</para>
        /// </description></item>
        /// <item><description><para>4: Narrowband HD 1.0 (<c>NarrowBandV1</c>)</para>
        /// </description></item>
        /// <item><description><para>5: Narrowband HD 2.0 (<c>NarrowBandV2</c>)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Screenshot Template subtypes:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Normal (<c>Normal</c>)</para>
        /// </description></item>
        /// <item><description><para>2: Sprite Image (<c>Sprite</c>)</para>
        /// </description></item>
        /// <item><description><para>3: WebVTT (<c>WebVtt</c>)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>AI Content Moderation subtypes:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Video moderation (<c>Video</c>)</para>
        /// </description></item>
        /// <item><description><para>2: Audio moderation (<c>Audio</c>)</para>
        /// </description></item>
        /// <item><description><para>3: Image moderation (<c>Image</c>)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>AI-powered Object Removal subtypes:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Logo Removal (<c>VideoDelogo</c>)</para>
        /// </description></item>
        /// <item><description><para>2: Text Removal (<c>VideoDetext</c>)</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Subtype")]
        [Validation(Required=false)]
        public string Subtype { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>96e8864746a0b6f3</b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The type of the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: Transcoding Template</para>
        /// </description></item>
        /// <item><description><para>2: Screenshot Template</para>
        /// </description></item>
        /// <item><description><para>3: Animated GIF Template</para>
        /// </description></item>
        /// <item><description><para>4: Image Watermark Template</para>
        /// </description></item>
        /// <item><description><para>5: Text Watermark Template</para>
        /// </description></item>
        /// <item><description><para>6: Subtitle Template</para>
        /// </description></item>
        /// <item><description><para>7: AI Content Moderation</para>
        /// </description></item>
        /// <item><description><para>8: AI-powered Smart Cover</para>
        /// </description></item>
        /// <item><description><para>9: AI-powered Object Removal</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
