// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class UpdatePtsSceneBaseLineShrinkRequest : TeaModel {
        /// <summary>
        /// <para>null null</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;avgRt&quot;:1,&quot;avgTps&quot;:1,&quot;failCountBiz&quot;:1,&quot;failCountReq&quot;:182381,&quot;id&quot;:362447,&quot;maxRt&quot;:3051,&quot;minRt&quot;:0,&quot;name&quot;:&quot;1-1&quot;,&quot;seg50Rt&quot;:1,&quot;seg75Rt&quot;:1,&quot;seg90Rt&quot;:1,&quot;seg99Rt&quot;:3,&quot;successRateBiz&quot;:1,&quot;successRateReq&quot;:0,&quot;timingConnAvg&quot;:0},{&quot;avgRt&quot;:1.06,&quot;avgTps&quot;:1,&quot;failCountBiz&quot;:0,&quot;failCountReq&quot;:151143,&quot;id&quot;:362446,&quot;maxRt&quot;:3068,&quot;minRt&quot;:0,&quot;name&quot;:&quot;dd&quot;,&quot;seg50Rt&quot;:1,&quot;seg75Rt&quot;:1,&quot;seg90Rt&quot;:1,&quot;seg99Rt&quot;:2,&quot;successRateBiz&quot;:1,&quot;successRateReq&quot;:0}]</para>
        /// </summary>
        [NameInMap("ApiBaselines")]
        [Validation(Required=false)]
        public string ApiBaselinesShrink { get; set; }

        /// <summary>
        /// <para>null null</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;avgRt&quot;:1,&quot;avgTps&quot;:1,&quot;failCountBiz&quot;:1,&quot;failCountReq&quot;:1,&quot;seg90Rt&quot;:1,&quot;seg99Rt&quot;:2,&quot;successRateBiz&quot;:0.5,&quot;successRateReq&quot;:1}</para>
        /// </summary>
        [NameInMap("SceneBaseline")]
        [Validation(Required=false)]
        public string SceneBaselineShrink { get; set; }

        /// <summary>
        /// <para>The ID of the scene. For more information, see the <a href="https://help.aliyun.com/document_detail/201321.html">table</a> provided in this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NB54CV</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

    }

}
