// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListComponentsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果体
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListComponentsResponseBodyResult Result { get; set; }
        public class ListComponentsResponseBodyResult : TeaModel {
            [NameInMap("ComponentCategory")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyResultComponentCategory> ComponentCategory { get; set; }
            public class ListComponentsResponseBodyResultComponentCategory : TeaModel {
                public List<ListComponentsResponseBodyResultComponentCategoryList> List { get; set; }
                public class ListComponentsResponseBodyResultComponentCategoryList : TeaModel {
                    public string ComponentName { get; set; }
                    public string ComponentType { get; set; }
                    public string InUse { get; set; }
                }
                public string Type { get; set; }
            }
            [NameInMap("ConfigGroup")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyResultConfigGroup> ConfigGroup { get; set; }
            public class ListComponentsResponseBodyResultConfigGroup : TeaModel {
                public string Category { get; set; }
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("SceneList")]
            [Validation(Required=false)]
            public List<ListComponentsResponseBodyResultSceneList> SceneList { get; set; }
            public class ListComponentsResponseBodyResultSceneList : TeaModel {
                public List<ListComponentsResponseBodyResultSceneListComponentCategory> ComponentCategory { get; set; }
                public class ListComponentsResponseBodyResultSceneListComponentCategory : TeaModel {
                    public List<ListComponentsResponseBodyResultSceneListComponentCategoryList> List { get; set; }
                    public class ListComponentsResponseBodyResultSceneListComponentCategoryList : TeaModel {
                        public string ComponentName { get; set; }
                        public string ComponentType { get; set; }
                        public string InUse { get; set; }
                    }
                    public string Type { get; set; }
                }
                public string Scene { get; set; }
            }
        };

    }

}
