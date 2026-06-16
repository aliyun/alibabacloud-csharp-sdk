// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class CreateAIStaffConversationRequest : TeaModel {
        /// <summary>
        /// <para>The user question text. The first 100 characters are truncated and used as the session title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>卫浴五金产品，表面采用拉丝不锈钢材质，整体色调为现代银灰色，呈现简约且富有质感的风格。产品包括淋浴花洒、水龙头及毛巾架等配件，均具备防锈、耐腐蚀性能，适用于潮湿环境。各部件连接处设计精密，配有隐藏式螺丝结构，提升整体美观度。水龙头和花洒喷头支持多模式出水，把手操作顺滑，符合人体工学设计。所有五金件通过国家节水认证，支持冷热水接入，安装方式为壁挂式。</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
