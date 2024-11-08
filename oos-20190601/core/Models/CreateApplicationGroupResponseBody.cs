// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application group.</para>
        /// </summary>
        [NameInMap("ApplicationGroup")]
        [Validation(Required=false)]
        public CreateApplicationGroupResponseBodyApplicationGroup ApplicationGroup { get; set; }
        public class CreateApplicationGroupResponseBodyApplicationGroup : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyApplication</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The ID of the application group in CloudMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1245768</para>
            /// </summary>
            [NameInMap("CmsGroupId")]
            [Validation(Required=false)]
            public string CmsGroupId { get; set; }

            /// <summary>
            /// <para>The time when the application group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-07T10:28:25Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the related sources reside.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DeployRegionId")]
            [Validation(Required=false)]
            public string DeployRegionId { get; set; }

            /// <summary>
            /// <para>The description of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ApplicationGroup</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("ImportTagKey")]
            [Validation(Required=false)]
            public string ImportTagKey { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("ImportTagValue")]
            [Validation(Required=false)]
            public string ImportTagValue { get; set; }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyApplicationGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the application group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-07T10:28:25Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E6BEBD3-7F9E-5878-834B-097633AB5F33</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
