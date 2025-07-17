// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateRumAppRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("AppGroup")]
        [Validation(Required=false)]
        public string AppGroup { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monitoring description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The language used by the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The nickname of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("NickName")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        /// <summary>
        /// <para>The name of the Android application package. This parameter is required if you create an Android application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.xxxx.xxxxxx</para>
        /// </summary>
        [NameInMap("PackageName")]
        [Validation(Required=false)]
        public string PackageName { get; set; }

        /// <summary>
        /// <para>The region where the application resides. You can leave this parameter empty or set it to China East 2 Finance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-finance-1</para>
        /// </summary>
        [NameInMap("RealRegionId")]
        [Validation(Required=false)]
        public string RealRegionId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The application type. Valid values: web, miniapp, ios, and android.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("SiteType")]
        [Validation(Required=false)]
        public string SiteType { get; set; }

        /// <summary>
        /// <para>The source. This is a reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The list of tags. You can specify a maximum of 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRumAppRequestTag> Tag { get; set; }
        public class CreateRumAppRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
