// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateCardSmsTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The vendors to which the template will be submitted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HuaWei</b>: Huawei</para>
        /// </description></item>
        /// <item><description><para><b>XiaoMi</b>: Xiaomi</para>
        /// </description></item>
        /// <item><description><para><b>OPPO</b>: OPPO</para>
        /// </description></item>
        /// <item><description><para><b>VIVO</b>: VIVO</para>
        /// </description></item>
        /// <item><description><para><b>MEIZU</b>: MEIZU</para>
        /// </description></item>
        /// <item><description><para><b>HONOR</b>: HONOR</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically submits the template to all supported mobile phone vendors.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;HuaWei&quot;,&quot;XiaoMi&quot;]</para>
        /// </summary>
        [NameInMap("Factorys")]
        [Validation(Required=false)]
        public string Factorys { get; set; }

        /// <summary>
        /// <para>A description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>图文类模板</para>
        /// </summary>
        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        /// <summary>
        /// <para>The content of the card SMS template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For more information about the <c>Template</c>, <c>ExtendInfo</c>, <c>TemplateContent</c>, <c>TmpCard</c>, and <c>Action</c> fields, see <a href="https://help.aliyun.com/document_detail/434929.html">Card SMS template parameters</a>.</para>
        /// </description></item>
        /// <item><description><para>The content structure varies based on the type of card SMS template. For more information, see <a href="https://help.aliyun.com/document_detail/435361.html">Card SMS template examples</a>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///        &quot;extendInfo&quot;:{
        ///               &quot;scene&quot;:&quot;HMOVM图文&quot;,
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
        ///                                                  &quot;merchantName&quot;:&quot;测试-图文模板&quot;,
        ///                                                  &quot;packageName&quot;:[
        ///                                                         &quot;com.taobao.taobao&quot;],
        ///                                                  &quot;floorUrl&quot;:&quot;<a href="https://s.tb.cn/c.KxzZ">https://s.tb.cn/c.KxzZ</a>&quot;
        ///                                           },
        ///                                           &quot;positionNumber&quot;:1
        ///                                    },
        ///                                    {
        ///                                           &quot;type&quot;:&quot;TEXT&quot;,
        ///                                           &quot;content&quot;:&quot;测试- BENZ AMG 2020 试驾邀请&quot;,
        ///                                           &quot;isTextTitle&quot;:true,
        ///                                           &quot;positionNumber&quot;:2
        ///                                    },
        ///                                    {
        ///                                           &quot;type&quot;:&quot;TEXT&quot;,
        ///                                           &quot;content&quot;:&quot;测试-梅赛德斯-奔驰，创新激情永不灭。作为汽车 XXXX&quot;,
        ///                                           &quot;isTextTitle&quot;:false,
        ///                                           &quot;positionNumber&quot;:3
        ///                                    },
        ///                                    {
        ///                                           &quot;type&quot;:&quot;BUTTON&quot;,
        ///                                           &quot;content&quot;:&quot;预约试驾&quot;,
        ///                                           &quot;actionType&quot;:&quot;OPEN_BROWSER&quot;,
        ///                                           &quot;action&quot;:{
        ///                                                  &quot;target&quot;:&quot;<a href="https://www.mercedes-benz.com.cn">https://www.mercedes-benz.com.cn</a>&quot;,
        ///                                                  &quot;merchantName&quot;:&quot;测试-正在跳转梅赛德斯-奔驰&quot;
        /// },
        ///                                           &quot;positionNumber&quot;:4
        ///                                    }]
        ///                      }]
        ///        },
        ///        &quot;cardSignName&quot;:&quot;阿里云&quot;,
        ///        &quot;cardType&quot;:5,
        ///        &quot;companyName&quot;: &quot;投放企业名称&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string TemplateShrink { get; set; }

        /// <summary>
        /// <para>The name of the card SMS template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云图文类模板</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
