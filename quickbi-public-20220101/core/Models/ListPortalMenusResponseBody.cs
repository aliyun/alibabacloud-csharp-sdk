// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListPortalMenusResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75912036-5527-4B7E-9265-B481D6651AC2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A JSON string that levels the details of the portal menu list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>menuType: the type of the menu.</para>
        /// <list type="bullet">
        /// <item><description>0: dashboard</description></item>
        /// <item><description>1: outer chain</description></item>
        /// <item><description>2: workbook</description></item>
        /// <item><description>4: directory folder</description></item>
        /// <item><description>5: form filling</description></item>
        /// <item><description>6: self-service data retrieval</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>menuId: menu ID</para>
        /// </description></item>
        /// <item><description><para>uri: ID or URL of the resource associated with the menu</para>
        /// </description></item>
        /// <item><description><para>showOnlyWithAccess: Authorized Only Visible</para>
        /// </description></item>
        /// <item><description><para>menuName: menu display name</para>
        /// </description></item>
        /// <item><description><para>dependentPermisson: whether the report resource associated with the menu has permissions</para>
        /// </description></item>
        /// <item><description><para>children: submenu</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;children&quot;:[{&quot;children&quot;:[{&quot;children&quot;:[{&quot;menuId&quot;:&quot;54kqgoa\<em>\</em>\<em>\</em>&quot;,&quot;menuName&quot;:&quot;Report menu&quot;,&quot;menuType&quot;:0,&quot;showOnlyWithAccess&quot;:true,&quot;dependentPermisson&quot;:false,&quot;uri&quot;:&quot;e5da4a3f-d7f9-4262-a39e-a840043c\<em>\</em>\<em>\</em>&quot;},{\<em>\</em>\<em>\</em> &quot;menu1nId&quot;:&quot;pName&quot; 135 &quot;Directory menu&quot;,&quot;menuType&quot;:4,&quot;showOnlyWithAccess&quot;:false,&quot;dependentPermisson&quot;:true}],&quot;menuId&quot;:&quot;23a7d5d8-e55a-4737-b6a1-3c585505\<em>\</em>\<em>\</em>&quot;,&quot;menuName&quot;:&quot;pop level -3 menu&quot;,&quot;menuType&quot;:4,&quot;showOnlyWithAccess&quot;:true,&quot;dependentPermisson&quot;:true}],&quot;menuId&quot;:&quot;80764 f3c-affd-45a1-aaa1-bb039d8a\<em>\</em>\<em>\</em>&quot;,&quot;menuName&quot;:&quot;pop menu&quot;,&quot;menuType&quot;:4,&quot;showOnlyWithAccess&quot;:false,&quot;dependentPermisson&quot;:true}],&quot;menuId&quot;:&quot;277 f968a-22 ff-4ce6-83f0-a82950f4\<em>\</em>\<em>\</em>&quot;,&quot;menuName&quot;:&quot;pop menu&quot;,&quot;menuType&quot;:4,&quot;showOnlyWithAccess&quot;:false,&quot;dependentPermisson&quot;:true}]</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
