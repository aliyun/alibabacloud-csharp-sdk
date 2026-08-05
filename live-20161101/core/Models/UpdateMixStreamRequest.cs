// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateMixStreamRequest : TeaModel {
        /// <summary>
        /// <para>The streaming domain.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Only domain names in the China (Shanghai) and China (Beijing) regions are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The list of input streams for the mix. This is a JSON array.</para>
        /// <para>For more information, see <b>InputStreamConfig</b> below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;InputStreamList&quot;:[{&quot;LayoutConfig&quot;:{&quot;FillSizeNormalized&quot;:[0.5,0.5],&quot;FillPositionNormalized&quot;:[0,0],&quot;PositionRefer&quot;:&quot;topLeft&quot;,&quot;FillMode&quot;:&quot;fit&quot;},&quot;LayoutChildId&quot;:1,&quot;ResourceValue&quot;:&quot;rtmp://aliyundoc.com/caster/8564a8d1659b4dc69df5f66cf4c9****&quot;,&quot;ResourceType&quot;:&quot;live&quot;},{&quot;LayoutConfig&quot;:{&quot;FillSizeNormalized&quot;:[0.5,0.5],&quot;FillPositionNormalized&quot;:[0.5,0],&quot;PositionRefer&quot;:&quot;topLeft&quot;,&quot;FillMode&quot;:&quot;fit&quot;},&quot;LayoutChildId&quot;:2,&quot;ResourceValue&quot;:&quot;<a href="http://developer.aliyundoc.com/3c3c25426cf744fdb90423e76b78a28a/69b1a16e2b1d423d9841bf27a96f134e-0b1cba51f58bb5ad3a854x96a2c735f****.mp4%22,%22ResourceType%22:%22url%22%7D,%7B%22LayoutConfig%22:%7B%22FillSizeNormalized%22:%5B1,0.5%5D,%22FillPositionNormalized%22:%5B0,0.5%5D,%22PositionRefer%22:%22topLeft%22,%22FillMode%22:%22fit%22%7D,%22LayoutChildId%22:3,%22ResourceValue%22:%22http://aliyundoc.com/c0c6c5446b56432389e91535864938da/ed4adc5263b4474c954b95607a5350ae-fda757b3328438a8cf-4k57f373a0f0****.mp4%22,%22ResourceType%22:%22url%22%7D%5D%7D">http://developer.aliyundoc.com/3c3c25426cf744fdb90423e76b78a28a/69b1a16e2b1d423d9841bf27a96f134e-0b1cba51f58bb5ad3a854x96a2c735f****.mp4&quot;,&quot;ResourceType&quot;:&quot;url&quot;},{&quot;LayoutConfig&quot;:{&quot;FillSizeNormalized&quot;:[1,0.5],&quot;FillPositionNormalized&quot;:[0,0.5],&quot;PositionRefer&quot;:&quot;topLeft&quot;,&quot;FillMode&quot;:&quot;fit&quot;},&quot;LayoutChildId&quot;:3,&quot;ResourceValue&quot;:&quot;http://aliyundoc.com/c0c6c5446b56432389e91535864938da/ed4adc5263b4474c954b95607a5350ae-fda757b3328438a8cf-4k57f373a0f0****.mp4&quot;,&quot;ResourceType&quot;:&quot;url&quot;}]}</a></para>
        /// </summary>
        [NameInMap("InputStreamList")]
        [Validation(Required=false)]
        public string InputStreamList { get; set; }

        /// <summary>
        /// <para>The layout ID. The following values are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MixStreamLayout-1-1</b></para>
        /// </description></item>
        /// <item><description><para><b>MixStreamLayout-2-1</b></para>
        /// </description></item>
        /// <item><description><para><b>MixStreamLayout-2-2</b></para>
        /// </description></item>
        /// <item><description><para><b>MixStreamLayout-2-3</b></para>
        /// </description></item>
        /// <item><description><para><b>MixStreamLayout-3-1</b></para>
        /// </description></item>
        /// <item><description><para><b>MixStreamLayout-3-2</b></para>
        /// </description></item>
        /// <item><description><para><b>MixStreamLayout-4-1</b></para>
        /// </description></item>
        /// <item><description><para><b>USERDEFINED</b> (If you use a custom layout instead of a preset layout, set this parameter to this value.)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MixStreamLayout-3-2</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        /// <summary>
        /// <para>The ID of the stream mix task. If you created the task by calling the <a href="https://help.aliyun.com/document_detail/2848087.html">CreateMixStream</a> operation, use the MixStreamId value returned in the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b2a046e-74d7-385e-d2d7-8a5b87e4****</para>
        /// </summary>
        [NameInMap("MixStreamId")]
        [Validation(Required=false)]
        public string MixStreamId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
