// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateCardSmsTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The mobile phone manufacturer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HuaWei</b>: HUAWEI</description></item>
        /// <item><description><b>XiaoMi</b>: Xiaomi</description></item>
        /// <item><description><b>OPPO</b>: OPPO</description></item>
        /// <item><description><b>VIVO</b>: vivo</description></item>
        /// <item><description><b>MEIZU</b>: MEIZU</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the system automatically specifies a supported mobile phone manufacturer.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>XiaoMi</para>
        /// </summary>
        [NameInMap("Factorys")]
        [Validation(Required=false)]
        public string Factorys { get; set; }

        /// <summary>
        /// <para>The description of the message template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Image and Text Template</para>
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>The content of the card message template.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>For information about fields such as Template, ExtendInfo, TemplateContent, TmpCard, and Action, see <a href="https://help.aliyun.com/document_detail/434929.html">Parameters of card message templates</a>.</para>
        /// </description></item>
        /// <item><description><para>Message template content varies based on the template type. For more information, see <a href="https://help.aliyun.com/document_detail/435361.html">Sample message templates</a>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///        &quot;extendInfo&quot;:{
        ///               &quot;scene&quot;:&quot;HMOVM&quot;,
        ///               &quot;purpose&quot;:&quot;2&quot;,
        ///               &quot;userExt&quot;:{
        ///                      &quot;outId&quot;:&quot;1234554321&quot;
        ///               }
        ///        },
        ///        &quot;templateContent&quot;:{
        ///               &quot;pages&quot;:[
        ///                      {
        /// &quot;tmpCards&quot;:[
        ///                                    {
        ///                                           &quot;type&quot;:&quot;IMAGE&quot;,
        ///                                           &quot;srcType&quot;:1,
        ///                                           &quot;src&quot;:&quot;28755&quot;,
        ///                                           &quot;actionType&quot;:&quot;OPEN_APP&quot;,
        ///                                           &quot;action&quot;:{
        ///                                                  &quot;target&quot;:&quot;<a href="https://s.tb.cn/c.KxzZ">https://s.tb.cn/c.KxzZ</a>&quot;,
        ///                                                  &quot;merchantName&quot;:&quot;test-template&quot;,
        ///                                                  &quot;packageName&quot;:[
        ///                                                         &quot;com.taobao.taobao&quot;],
        ///                                                  &quot;floorUrl&quot;:&quot;<a href="https://s.tb.cn/c.KxzZ">https://s.tb.cn/c.KxzZ</a>&quot;
        ///                                           },
        ///                                           &quot;positionNumber&quot;:1
        ///                                    },
        ///                                    {
        ///                                           &quot;type&quot;:&quot;TEXT&quot;,
        ///                                           &quot;content&quot;:&quot;this is a test msg.&quot;,
        ///                                           &quot;isTextTitle&quot;:true,
        ///                                           &quot;positionNumber&quot;:2
        ///                                    },
        ///                                    {
        ///                                           &quot;type&quot;:&quot;TEXT&quot;,
        ///                                           &quot;content&quot;:&quot;Promotional information&quot;,
        ///                                           &quot;isTextTitle&quot;:false,
        ///                                           &quot;positionNumber&quot;:3
        ///                                    },
        ///                                    {
        ///                                           &quot;type&quot;:&quot;BUTTON&quot;,
        ///                                           &quot;content&quot;:&quot;Promotional information,&quot;,
        ///                                           &quot;actionType&quot;:&quot;OPEN_BROWSER&quot;,
        ///                                           &quot;action&quot;:{
        ///                                                  &quot;target&quot;:&quot;<a href="https://www.aliyun.com">https://www.aliyun.com</a>&quot;,
        ///                                                  &quot;merchantName&quot;:&quot;Currently on the Alibaba Cloud official website.&quot;
        /// },
        ///                                           &quot;positionNumber&quot;:4
        ///                                    }]
        ///                      }]
        ///        },
        ///        &quot;cardSignName&quot;:&quot;aliyun&quot;,
        ///        &quot;cardType&quot;:5
        /// }</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string TemplateShrink { get; set; }

        /// <summary>
        /// <para>The name of the card message template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun Image and Text Template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
